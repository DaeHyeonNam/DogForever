import nltk
from nltk.corpus import state_union
from nltk.tokenize import PunktSentenceTokenizer

speechs = ['JJ','JJR','JJS','RB','RBR','UH','VB','VBD','VBG','VBN','VBP','VBZ']
sen_len = 1
for i in range(0, sen_len)
    document = 'Today the Netherlands celebrates King\'s Day. To honor this tradition, the Dutch embassy in San Francisco invited me to'
    sentences = nltk.sent_tokenize(document)   

    data, datas = [], []

    for sent in sentences:
        data = data + nltk.pos_tag(nltk.word_tokenize(sent))
    #print(data)
    for word in data: 
        if speechs.count(word[1])!= 0: 
            print(word)
            datas.append(word[0])
    print(datas)
