
export class Booking {
  
  constructor(
        public id?: number,
        public user_name?: string,
        public club_name?: string,
        public date?: Date,
        public time?: string,
        public length?: number,
        public type?: string,
        public price?: number,
        public author_name?:string,
        public state?: string,
        public comment?: string
  ) { }

   
}