class Node:

    def __init__(self,data):
        self.data=data;
        self.next =None

class LinkedList:
    
    def __init__(self):
        self.head = Node(-1)

    
    def get(self, index: int) -> int:
        ci=-1
        ch = self.head
        while ch:
            if ci==index:
                return ch.data
            ch = ch.next
            ci += 1
        return -1


    def insertHead(self, val: int) -> None:
        ch = self.head.next
        self.head.next = Node(val)
        self.head.next.next = ch
        

    def insertTail(self, val: int) -> None:
        ch = self.head
        while ch.next:
            ch = ch.next
        ch.next = Node(val)

    def remove(self, index: int) -> bool:
        ci=-1
        ch = self.head
        while ch:
            if ci==index-1:
                if(ch.next):
                    ch.next = ch.next.next
                    return True
                else:
                    return False
            ch = ch.next
            ci += 1
        return False
        

        
    def getValues(self) -> List[int]:
        l=[]
        ch = self.head.next
        while ch:
            l.append(ch.data)
            ch = ch.next
        return l



        
