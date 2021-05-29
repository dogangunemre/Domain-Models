<?php
namespace Ohtap\ECommerce\DomainModels\Objects\PackageAttributes;



class PackageAttributeBasic implements IPackageAttributeData
{   public $ID;
    public $Details;//AttributeDetailDataList
    public $Attribute;//Attribute
    public $State;
    public $Value;
    public $OrderNo;
    public $Description;

}