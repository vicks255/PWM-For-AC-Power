int 	         iCycle      = 0;
int             iReadByte;
int             iOffset = 0;

unsigned long           iVA = 0;
unsigned long           iVB = 0;
double                        iVStart = 0;

long         iOn = 0;
long         iOff = 0;
long         lngPhaseShift = 0;
float         fDutyCycle = 0;

boolean  bRead = false;
boolean  bAck = false;
boolean  bIncandescent = false;
boolean  bACLED = false;
boolean  bDCLD = false;

char         cRead [3];
String      strComm;
String      strReturn = "ack";


void setup()
{
  pinMode(31, OUTPUT);
  Serial.begin(9600);
}

void loop()
{ 
  if(fDutyCycle > 0)
  {
    iVA = analogRead(29);
    iVB = analogRead(27);
    iVStart = abs(iVA - iVB);
  
  
    if (bACLED == true)
    {
      if(iVStart <= iOffset and fDutyCycle > 0 and fDutyCycle < 100)
      {
        delayMicroseconds(lngPhaseShift);
        digitalWrite(31, HIGH);
        delayMicroseconds(iOn);
        digitalWrite(31,LOW);
        delayMicroseconds(iOff);
        digitalWrite(31, HIGH);
        delayMicroseconds(iOn);
        digitalWrite(31, LOW); 
      }
    }
  
  
    if(bIncandescent == true)
    {
     if(iVStart <= iOffset and fDutyCycle > 0 and fDutyCycle < 100)
     {
       delayMicroseconds(lngPhaseShift);
       digitalWrite(31, HIGH);
       delayMicroseconds(iOn);
       digitalWrite(31, LOW); 
     }
    }
  }


  if(bRead == true)
  {    
    iCycle = 0;
    iCycle          = (int(cRead[0]) - 48) * 10;
    iCycle          = iCycle + int(cRead[1] - 48);
    fDutyCycle  = iCycle * 0.01;
     
     if(fDutyCycle == 0)
     {
        digitalWrite(31, LOW);
     }
     
    if(bACLED == true)
    {
      lngPhaseShift = 3025 * fDutyCycle;
      iOn = 1042;
      iOff = 8333 - (2 * iOn) - (2 * lngPhaseShift);
    }
    
    if(bIncandescent == true)
    {
      fDutyCycle = 1 - fDutyCycle;
      lngPhaseShift = 3646 + (3646 * fDutyCycle) - 100;
      iOn = 1042;
      iOff = 0;
    }
    
        
    if(iCycle == 0) 
    {
      lngPhaseShift = 0;
      iOn = 0;
      iOff = 0;
      fDutyCycle = 0;
    }
    
    Serial.println("Pulse Width: " + String(iOn));
    Serial.println("Phase Offset: " + String(lngPhaseShift));
    delayMicroseconds(8333);
    bRead = false;
  }


// LOOP FOR RECEIVING DATA FROM UI COMPUTER
  iCycle = 0;
  strComm = "";
  while(Serial.available())
  {
    iReadByte = Serial.read();    
    strComm = strComm + char(iReadByte);
    
    if(iReadByte > 47 and iReadByte < 58)
    {
      cRead[iCycle] = char(iReadByte);
       bRead = true;
    }
    iCycle++;
  }// END WHILE(0)
  
  
  
  
  if(strComm == "DM")
  {
    Serial.println("ACK");
    strComm = ""; 
  }
  
  if(strComm == "AA")
  {
    bIncandescent = true;
    bACLED = false;
    bDCLD = false;
    Serial.println("Incandescent");
    strComm = ""; 
  }
  
  if(strComm == "BB")
  {
    bIncandescent = false;
    bACLED = true;
    bDCLD = false;
    Serial.println("AC LED");
    strComm = ""; 
  }  
  
  if(strComm == "CC")
  {
    bIncandescent = false;
    bACLED = false;
    bDCLD = true;
    Serial.println("DC LED");
    strComm = ""; 
  }
  
  if(strComm == "II")
  {
    Serial.println("100%");
    strComm = "";
    digitalWrite(31, HIGH);
    iOn = 100;
    lngPhaseShift = 0;
    Serial.println("100%");
  }
}// END LOOP
