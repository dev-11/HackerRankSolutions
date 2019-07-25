vowel = 'AEIOU'

def minion_game(s):
    kevin_score = 0
    stuart_score = 0
    # your code goes here
    for i in range(len(s)):
        if s[i] in vowel:
            kevin_score += (len(s)-i)
        else:
            stuart_score += (len(s)-i)
    
    if kevin_score > stuart_score :
        print("Kevin", kevin_score)
    elif kevin_score < stuart_score :
        print("Stuart", stuart_score)
    else:
        print("Draw")

