<?php


namespace Ohtap\ECommerce\DomainModels\Objects\Categories;


class CategoryBasic implements ICategoryDetailDetailData
{
    public $ID;
    public $Parent;//CategoryBasic
    public $Photo;//FileData
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;


}