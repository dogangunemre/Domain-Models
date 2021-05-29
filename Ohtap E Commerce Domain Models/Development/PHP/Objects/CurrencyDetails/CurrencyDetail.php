<?php
namespace Ohtap\ECommerce\DomainModels\Objects\CurrencyDetail;
use   Ohtap\ECommerce\DomainModels\Objects\Languages;
class CurrencyDetail  implements ICurrencyDetail
{

   // public Language $Language;//Language sınıfını yüklemiyor bak
    public string $ID;
    public string $Name;
    public int $State;
    public int $OrderNo;
    public string $Description;
}