export class about {
    activate() {
        $.ajax({
            url: "http://localhost:5000/about",
            method: "GET"
        })
            .done(data => {
                this.author = data;
            });
    }
}