<?php
namespace Ohtap\ECommerce\DomainModels\Objects\PackageAttributes;

class PackageAttribute  implements ILabel
{

    public $ID;
    public $Details;//AttributeDetailDataList
    public $Attribute;//Attribute
    public $State;
    public $Value;
    public $OrderNo;
    public $Description;
}