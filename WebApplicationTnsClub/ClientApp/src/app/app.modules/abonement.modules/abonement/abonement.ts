import { Session } from "../../aboutclub.modules/session/session";
import { Booking } from "../../booking.modules/booking/booking";

export class Abonement {
  
    constructor(
        public id?: number,         
        public bookings?:Booking[] ,
        public sessions?:Session[],
        public price?:number,
        public isAutorenewal?:boolean 

 ) { }

   
}

