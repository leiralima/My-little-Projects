op = 0
num1 = 0
num2 = 0

def setNum():
    global num1
    global num2
    num1 = float(input('Insert first number: '))
    num2 = float(input('Insert second number: '))
    return 'Numbers set! Number 1: {0}; Number 2: {1}'.format(num1,num2)

def addNumbers(): #Add numbers
    sumNum = num1 + num2
    return 'Sum of {0} and {1} is {2}'.format(num1,num2,sumNum)

def subNumbers(): #Subtract numbers
    sumNum = num1 - num2
    return 'Subtraction of {0} and {1} is {2}'.format(num1,num2,sumNum)

def multNumbers(): #Multiply numbers
    sumNum = num1 * num2
    return 'Multiplication of {0} and {1} is {2}'.format(num1,num2,sumNum)

def divNumbers(): #Divide numbers
    sumNum = num1 / num2
    return 'Division of {0} and {1} is {2}'.format(num1,num2,sumNum)

def exitProgram(): #Exit
    return 'Exiting program'

def default(): #If an invalid input option is entered, then output this message
  return 'Invalid input'

while(op != '6'): #Any input that isn't "6" keeps the program going, but the input "6" ends it
    print('Menu: ')
    print('1) Set numbers')
    print('2) Add numbers')
    print('3) Subtract numbers')
    print('4) Multiply numbers')
    print('5) Divide numbers')
    print('6) Exit')

    op = input('\nPlease enter your choice: ') #Operator

    choices_dict = {'1': setNum, '2': addNumbers, '3': subNumbers, '4': multNumbers, '5': divNumbers, '6': exitProgram} #Dictionary of choices

    print(choices_dict.get(op, default)(),'\n') #Prints the def chosen, the dictionary defined the name of the def and will execute it