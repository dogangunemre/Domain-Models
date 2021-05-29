<?php
namespace Ohtap\ECommerce\DomainModels\Objects\PackageAttributes;

class PackageAttributeBasicFilter  implements IPackageAttributeBasicFilter
{
    public $LanguageCode;
    public $Name;
    public $ID;
    public $Details;//AttributeDetailDataList
    public $Attribute;//Attribute
    public $State;
    public $Value;
    public $OrderNo;
    public $Description;

}

