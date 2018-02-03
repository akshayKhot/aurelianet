import {BlogService} from "./Services/blog-service";

export class about {

    constructor(blogService) {
        this.blogService = blogService;
    }

    static inject() {
        return [BlogService];
    }
    
    activate() {
        this.blogService.getAuthor(1)
            .then(data => {
                this.author = data;
            });
    }
}