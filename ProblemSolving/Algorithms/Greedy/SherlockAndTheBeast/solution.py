for _ in range(int(input())):
    start_number=int(input())
    decent_number=start_number
    
    while(decent_number%3!=0):
        decent_number-=5
    
    print('-1' if decent_number<0 else decent_number*'5'+(start_number-decent_number)*'3')

