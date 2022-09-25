import Foundation
import Glibc
//cerner_2^5_2022
print("Please enter the lower limit -")
var lowerLimit = Int(readLine()!)!

print("Please enter the upper limit -")
var upperLimit = Int(readLine()!)!

var sumOfNaturalNumber = 0
for j in lowerLimit...upperLimit{
	sumOfNaturalNumber = sumOfNaturalNumber + j
}

print("Entered lower limit is - ", lowerLimit)
print("Entered upper limit is -", upperLimit)
print("Natural number’s sum is - ", sumOfNaturalNumber)