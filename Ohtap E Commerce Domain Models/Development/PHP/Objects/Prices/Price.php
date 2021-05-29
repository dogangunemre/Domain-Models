<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Prices;

use Ohtap\ECommerce\DomainModels\Objects\Currencies\ICurrencyDataList;

class Price  implements IPrice
{


    public  ICurrencyDataList $Currencies;
    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $ID;
    public string $Name;

}