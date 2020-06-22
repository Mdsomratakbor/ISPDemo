# ISPDemo


### What is Interface Segregation Priciple in SOLID?
`The Interface Segregation Principle is one of the SOLID principles defined by Robert C. Martin. It is one of the rules of software development that says to always code according to a contract, in other words an interface, not against the implementation, in other words a concrete class, because coding against an interface provides advantages like flexibility, loose coupling, testable code and so on. This principle is related to creating an interface for implementation.`

`The principle says “Client (class implementation interface) should not force to implement Interface that they don't use.” In simple words the principle is saying, do not design a big fat interface that forces the client to implement a method that is not required by it, instead design a small interface. So by doing this class only implement the required set of interface(s).`

`If there is big fat interface then break it into a set of small interfaces with the related method(s) in it. It's similar to normalizing our database like normalizing database from 1NF to 3NF where a big table is broken into tables with related columns.`

### Interface Segregation Principle in Real life
`In terms of the violation of the ISP, the following image shows a big dustbin for throwing all kinds of garbage away without any kind of segregation.`
<img alt="Dustbin " class="" data-src="/UploadFile/pranayamr/overview-of-interface-segregation-principle/Images/dustbin.jpg" src="https://www.c-sharpcorner.com/UploadFile/pranayamr/overview-of-interface-segregation-principle/Images/dustbin.jpg">
