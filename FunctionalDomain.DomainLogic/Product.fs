namespace FunctionalDomain.DomainLogic

  type public Product (code:string, price:float) = 
   let isFree = price=0.0 
   new (code) = Product(code,0.0)
   member this.Code = code 
   member this.IsFree = isFree
