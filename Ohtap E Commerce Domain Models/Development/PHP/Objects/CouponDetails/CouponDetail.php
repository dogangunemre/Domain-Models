<?php
namespace Ohtap\ECommerce\DomainModels\Objects\CouponDetail;
use Ohtap\ECommerce\DomainModels\Objects\LanguageDetails\ILanguageDetail;
use   Ohtap\ECommerce\DomainModels\Objects\LanguageDetails;
class CouponDetail  implements ICouponDetail
{

   // public Language $Language;//Language sınıfını yüklemiyor bak
    public ILanguageDetail $Language;
    public string $ID;
    public string $Name;
    public int $State;
    public int $OrderNo;
    public string $Description;
}