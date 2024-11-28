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
        public id?: string,
        public avatarfile?: string,
        public login?: string,
        public username?: string,
        public password?:string,
        public firstname?: string,
        public secondname?: string,
        public lastname?: string,
        public comment?:string) { }

   
}

