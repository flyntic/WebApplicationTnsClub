import { User } from "../user/user";

export class Parent {
  
    constructor(
        public id?: string,
        public avatarFile?: string,
        public firstName?: string,
        public secondName?: string,
        public lastName?: string//,
       // public childs: User[]
    ) { }

   
}

