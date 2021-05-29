<?php
namespace Ohtap\ECommerce\DomainModels\Objects\LanguageDetails;

class LanguageDetail  implements ILanguageDetail
{
    public $ID;
    public $Details;//LanguageDetailList
    public $State;
    public $LanguageCode;
    public $Title;
    public $Name;
    public $OrderNo;
    public $Description;
}