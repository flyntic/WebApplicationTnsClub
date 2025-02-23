import { Club } from "../../aboutclub.modules/club/club";

export class Author {
  
    constructor(
        public id?: string,
        public avatarFile?: string,
        public firstName?: string,
        public secondName?: string,
        public lastName?: string//,
        //public clubs: Club[]
    ) { }

   
}

