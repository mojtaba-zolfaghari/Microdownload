var ExtendedNumberFilter = (function (base) {
    MvcGridExtends(ExtendedNumberFilter, base);

    function ExtendedNumberFilter() {
        base.apply(this);

        this.methods.unshift('contains');
    }

    return ExtendedNumberFilter;
})(MvcGridNumberFilter);

$('.mvc-grid').mvcgrid({
    filters: {
        'number': new ExtendedNumberFilter()
    }
});

$.fn.mvcgrid.lang.number.contains = 'شامل باشد';
