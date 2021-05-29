<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Packages;



class PackageBasic implements IPackageData
{
    public $Barcode;//
    public $SKU;
    public $Units;//UnitBasic
    public $Measures;//MeasureList
    public $Prices;//PriceList
    public $Products;//ProductList
    public $ID;
    public $Title;
    public $Name;
    public $Details;
    public $State;
    public $OrderNo;
    public $Description;

}