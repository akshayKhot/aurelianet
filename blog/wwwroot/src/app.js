export class App {
    constructor() {
        this.heading = "Scielosophy";
    }
    
    configureRouter(config, router) {
        this.router = router;
        config.title = 'Aurelia';
        const navStrat = (instruction) => {
            instruction.config.moduleId = instruction.fragment
            instruction.config.href = instruction.fragment
        };
        config.map([
          { route: ['', 'home'],       name: 'home',   moduleId: 'home', title: 'Home'},
          { route: 'about',            name: 'about',  moduleId: 'about', nav: true, title: 'About' },
          { route: 'add',              name: 'add',    moduleId: 'add', nav: true, title: 'Add New Post' },
          { route: 'update',           name: 'update', moduleId: 'update', title: 'Update' }
        ]);
    }
}