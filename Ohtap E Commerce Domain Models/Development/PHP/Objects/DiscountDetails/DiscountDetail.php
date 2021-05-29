<?php
namespace Ohtap\ECommerce\DomainModels\Objects\DiscountDetail;
use Ohtap\ECommerce\DomainModels\Objects\LanguageDetails\ILanguageDetail;
use   Ohtap\ECommerce\DomainModels\Objects\Languages;
class DiscountDetail  implements IDiscountDetail
{

   // public Language $Language;//Language sınıfını yüklemiyor bak
    public ILanguageDetail $Language;
    public string $ID;
    public string $Name;
    public int $State;
    public int $OrderNo;
    public string $Description;
}