class DynamicArray:

    arrlen = 0
    capacity = 0
    arr=[]
    
    def __init__(self, capacity: int):
        self.capacity = capacity;
        self.arr=[]
        for i in range(capacity):
            self.arr.append(-1)
        


    def get(self, i: int) -> int:
        return self.arr[i]

    def set(self, i: int, n: int) -> None:
        if self.arr[i]==-1:
            self.arrlen += 1
        self.arr[i]=n


    def pushback(self, n: int) -> None:
        if self.arrlen >= self.capacity:
            self.resize();
        for i in range(len(self.arr)-1,-1,-1):
            if i==0 or( self.arr[i]==-1 and self.arr[i-1]!=-1):
                self.arr[i]=n
                self.arrlen += 1
                break;
        

    def popback(self) -> int:
        for i in range(len(self.arr)-1,-1,-1):
            if self.arr[i]!=-1:
                self.arrlen -=1
                x = self.arr[i]
                self.arr[i]=-1
                return x

    def resize(self) -> None:
        for i in range(0,self.capacity):
            self.arr.append(-1)
        self.capacity = self.capacity*2


    def getSize(self) -> int:
        return self.arrlen
    
    def getCapacity(self) -> int:
        return self.capacity
