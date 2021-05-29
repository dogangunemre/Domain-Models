<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;

use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;

class PromotionBasicFilter  implements IPromotionBasicFilter
{
    public string $Description;
    public int $EndDate;//long
    public int $StartDate;//long
    public IDiscountData $Discount;
    public int $State;
    public int $OrderNo;
    public string $ID;
    public string $Name;

}

