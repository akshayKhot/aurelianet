export class App {
    constructor() {
        this.heading = "My blog";
    }
    
    configureRouter(config, router) {
        this.router = router;
        config.title = 'Aurelia';
        const navStrat = (instruction) => {
            instruction.config.moduleId = instruction.fragment
            instruction.config.href = instruction.fragment
        };
        config.map([
          { route: ['', 'home'],       name: 'home',   moduleId: 'home', nav: true, title: 'Home'},
          { route: 'about',            name: 'about',  moduleId: 'about', nav: true, title: 'About' },
          { route: 'add',              name: 'add',    moduleId: 'add', nav: true, title: 'Add' },
          { route: 'update',           name: 'update', moduleId: 'update', title: 'Update' }
        ]);
    }
}