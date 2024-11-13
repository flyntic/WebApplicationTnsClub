/*
export class BaseId {

    constructor(
        public id?: any,
        public datecreate?: any,
        public dateupdate?: any,
        public isdeleted?: boolean) { }


}
*/
export class User {
  
  constructor(
        public id?: number,
        public name?: string,
        public last_name?: string,
        public avatarfile?: string,
        public login?: string) { }

   
}