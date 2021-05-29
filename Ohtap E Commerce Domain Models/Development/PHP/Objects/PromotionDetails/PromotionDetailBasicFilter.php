<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;

use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;

class PromotionDetailBasicFilter  implements IPromotionBasicFilter
{
    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $Name;


}

