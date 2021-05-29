<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Variations;

class Variation  implements ILabel
{
    public $Details;//VariationList
    public $Products;//ProductList
    public $Packages;//PackageList
    public $ID;
    public $Name;
    public $Title;
    public $State;
    public $OrderNo;
    public $Description;
}