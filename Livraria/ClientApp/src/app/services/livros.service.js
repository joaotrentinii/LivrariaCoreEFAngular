"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var LivrosService = /** @class */ (function () {
    function LivrosService(http) {
        this.http = http;
        this.baseUrl = 'http://localhost:59035/api';
    }
    LivrosService.prototype.postLivro = function () {
        return this.http.post(this.baseUrl + '/Livraria', this.livro);
    };
    LivrosService.prototype.putLivro = function () {
        return this.http.put(this.baseUrl + '/Livraria/' + this.livro.livroId, this.livro);
    };
    LivrosService.prototype.deleteLivro = function (id) {
        return this.http.delete(this.baseUrl + '/Livraria/' + this.livro.livroId);
    };
    LivrosService.prototype.refreshList = function () {
        var _this = this;
        this.http.get(this.baseUrl + '/Livraria')
            .toPromise()
            .then(function (res) { return _this.livros = res; });
    };
    return LivrosService;
}());
exports.LivrosService = LivrosService;
//# sourceMappingURL=livros.service.js.map