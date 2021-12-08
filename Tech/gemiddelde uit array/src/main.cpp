#include <Arduino.h>
double values [5];
double sum = 0;

int BPM;
double minuteBPM[60];
double gemBPM = 0;

int Signal = 0;
const int PulseSensorPurplePin = A0;

int i = 0;

void setup()
{
  Serial.begin(9600);
/*
  values[0] = analogRead(PulseSensorPurplePin); 
  values[1] = analogRead(PulseSensorPurplePin);
  values[2] = analogRead(PulseSensorPurplePin);
  values[3] = analogRead(PulseSensorPurplePin);
  values[4] = analogRead(PulseSensorPurplePin);

  

  sum = values[0] + values[1] + values[2] + values[3] + values[4];

for (int i = 0; i <5; i++)
{
  Serial.println(values[i]);
  delay(500);
}
Serial.println(sum/5);

delay(2000);*/
}

void loop() 
{
minuteBPM[0] = analogRead(PulseSensorPurplePin);
minuteBPM[1] = analogRead(PulseSensorPurplePin);
minuteBPM[2] = analogRead(PulseSensorPurplePin);
minuteBPM[3] = analogRead(PulseSensorPurplePin);
minuteBPM[4] = analogRead(PulseSensorPurplePin);
minuteBPM[5] = analogRead(PulseSensorPurplePin);
minuteBPM[6] = analogRead(PulseSensorPurplePin);
minuteBPM[7] = analogRead(PulseSensorPurplePin);
minuteBPM[8] = analogRead(PulseSensorPurplePin);
minuteBPM[9] = analogRead(PulseSensorPurplePin);
minuteBPM[10] = analogRead(PulseSensorPurplePin);
minuteBPM[11] = analogRead(PulseSensorPurplePin);
minuteBPM[12] = analogRead(PulseSensorPurplePin);
minuteBPM[13] = analogRead(PulseSensorPurplePin);
minuteBPM[14] = analogRead(PulseSensorPurplePin);
minuteBPM[15] = analogRead(PulseSensorPurplePin);
minuteBPM[16] = analogRead(PulseSensorPurplePin);
minuteBPM[17] = analogRead(PulseSensorPurplePin);
minuteBPM[18] = analogRead(PulseSensorPurplePin);
minuteBPM[19] = analogRead(PulseSensorPurplePin);
minuteBPM[20] = analogRead(PulseSensorPurplePin);
minuteBPM[21] = analogRead(PulseSensorPurplePin);
minuteBPM[22] = analogRead(PulseSensorPurplePin);
minuteBPM[23] = analogRead(PulseSensorPurplePin);
minuteBPM[24] = analogRead(PulseSensorPurplePin);
minuteBPM[25] = analogRead(PulseSensorPurplePin);
minuteBPM[26] = analogRead(PulseSensorPurplePin);
minuteBPM[27] = analogRead(PulseSensorPurplePin);
minuteBPM[28] = analogRead(PulseSensorPurplePin);
minuteBPM[29] = analogRead(PulseSensorPurplePin);
minuteBPM[30] = analogRead(PulseSensorPurplePin);
minuteBPM[31] = analogRead(PulseSensorPurplePin);
minuteBPM[32] = analogRead(PulseSensorPurplePin);
minuteBPM[33] = analogRead(PulseSensorPurplePin);
minuteBPM[34] = analogRead(PulseSensorPurplePin);
minuteBPM[35] = analogRead(PulseSensorPurplePin);
minuteBPM[36] = analogRead(PulseSensorPurplePin);
minuteBPM[37] = analogRead(PulseSensorPurplePin);
minuteBPM[38] = analogRead(PulseSensorPurplePin);
minuteBPM[39] = analogRead(PulseSensorPurplePin);
minuteBPM[40] = analogRead(PulseSensorPurplePin);
minuteBPM[41] = analogRead(PulseSensorPurplePin);
minuteBPM[42] = analogRead(PulseSensorPurplePin);
minuteBPM[43] = analogRead(PulseSensorPurplePin);
minuteBPM[44] = analogRead(PulseSensorPurplePin);
minuteBPM[45] = analogRead(PulseSensorPurplePin);
minuteBPM[46] = analogRead(PulseSensorPurplePin);
minuteBPM[47] = analogRead(PulseSensorPurplePin);
minuteBPM[48] = analogRead(PulseSensorPurplePin);
minuteBPM[49] = analogRead(PulseSensorPurplePin);
minuteBPM[50] = analogRead(PulseSensorPurplePin);
minuteBPM[51] = analogRead(PulseSensorPurplePin);
minuteBPM[52] = analogRead(PulseSensorPurplePin);
minuteBPM[53] = analogRead(PulseSensorPurplePin);
minuteBPM[54] = analogRead(PulseSensorPurplePin);
minuteBPM[55] = analogRead(PulseSensorPurplePin);
minuteBPM[56] = analogRead(PulseSensorPurplePin);
minuteBPM[57] = analogRead(PulseSensorPurplePin);
minuteBPM[58] = analogRead(PulseSensorPurplePin);
minuteBPM[59] = analogRead(PulseSensorPurplePin);
minuteBPM[60] = analogRead(PulseSensorPurplePin);

gemBPM = minuteBPM[0]+
minuteBPM[1] +
minuteBPM[2] +
minuteBPM[3] +
minuteBPM[4] +
minuteBPM[5] +
minuteBPM[6] +
minuteBPM[7] +
minuteBPM[8] +
minuteBPM[9] +
minuteBPM[10]+
minuteBPM[11]+
minuteBPM[12]+
minuteBPM[13]+
minuteBPM[14]+
minuteBPM[15]+
minuteBPM[16]+
minuteBPM[17]+
minuteBPM[18]+
minuteBPM[19]+
minuteBPM[20]+
minuteBPM[21]+
minuteBPM[22]+
minuteBPM[23]+
minuteBPM[24]+
minuteBPM[25]+
minuteBPM[26]+
minuteBPM[27]+
minuteBPM[28]+
minuteBPM[29]+
minuteBPM[30]+
minuteBPM[31]+
minuteBPM[32]+
minuteBPM[33]+
minuteBPM[34]+
minuteBPM[35]+
minuteBPM[36]+
minuteBPM[37]+
minuteBPM[38]+
minuteBPM[39]+
minuteBPM[40]+
minuteBPM[41]+
minuteBPM[42]+
minuteBPM[43]+
minuteBPM[44]+
minuteBPM[45]+
minuteBPM[46]+
minuteBPM[47]+
minuteBPM[48]+
minuteBPM[49]+
minuteBPM[50]+
minuteBPM[51]+
minuteBPM[52]+
minuteBPM[53]+
minuteBPM[54]+
minuteBPM[55]+
minuteBPM[56]+
minuteBPM[57]+
minuteBPM[58]+
minuteBPM[59]+
minuteBPM[60];
delay(1000);
Serial.println(".");
Serial.println(".");
Serial.println(".");
Serial.println(gemBPM/60);
/*
  for (int tellen = 0; tellen <= 60; tellen ++)
  {
  Signal = analogRead(PulseSensorPurplePin);
	BPM = map(Signal, 0, 1000, 0, 100);
  gemBPM = (minuteBPM[i]=Signal);
  Serial.println(Signal);
  delay(100);
  }

  Serial.print("BPM:");
  Serial.println(BPM*100);
  Serial.println(" ");
  Serial.println(gemBPM/60);
  delay(1000);*/
}
