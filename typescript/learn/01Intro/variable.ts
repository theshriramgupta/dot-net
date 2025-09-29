// string

let greetings : string = "Hello, TypeScript!";

greetings.toLowerCase();
console.log(greetings);


// number

let userId : number = 3453435;


// boolean
let isLoggedIn : boolean = false;

isLoggedIn.valueOf();
console.log(isLoggedIn);



// any
// inferred

let hero : any;
function getHero() {
    return 345
}

hero = getHero();



export {};