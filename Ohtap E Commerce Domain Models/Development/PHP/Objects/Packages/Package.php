<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Packages;

class Package  implements IPackage
{

    public $Categories;//CategoryList
    public $Tax;//TaxBasic
    public $Photos;//FileList
    public $Options;//OptionPackageList
    public $Labels;//OptionLabelList
    public $FeedBacks;//FeedbackList
    public $Attributes;//AttributeList
    public $Details;//PackageDetailList
    public $Discounts;//DiscountBasic
    public $Warehouses;//WarehouseList
    public $Specifications;//PackageSpecificationList
    public $Barcode;//
    public $SKU;
    public $Units;//UnitBasic
    public $Measures;//MeasureList
    public $Prices;//PriceList
    public $Products;//ProductList
    public $ID;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;
}