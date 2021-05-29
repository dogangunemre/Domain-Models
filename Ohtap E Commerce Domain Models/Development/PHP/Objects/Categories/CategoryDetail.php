<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Categories;


class CategoryDetail  implements ICategoryDetail

{
    public $ID;
    public $Childs;//CategoryList
    public $Details;//CategoryDetailList
    public $Parent;//CategoryBasic
    public $Photo;//FileData
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;

}

