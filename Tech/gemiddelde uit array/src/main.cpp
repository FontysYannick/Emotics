#include <Arduino.h>
double values [5] = {10,2,6,34,60};

double sum = 0;
int main() {

for (int i = 0; i <5; i++)
{
  sum = sum + values[i];
}

Serial.println(sum/5);
return 0;
}

void loop() 
{
Serial.println(sum);

}