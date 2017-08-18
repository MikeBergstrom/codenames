import json


wordFile = open("wordList.txt", 'r')
wordsList = [line.split(",") for line in wordFile.readlines()]

# print wordsList[0]

print json.dumps(wordsList[0])

finalList = open("gameWords.txt", 'w')
finalList.write(json.dumps(wordsList[0]))