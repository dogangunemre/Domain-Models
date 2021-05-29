<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;

use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;
use Ohtap\ECommerce\DomainModels\Objects\Files\IFileData;
use Ohtap\ECommerce\DomainModels\Objects\Packages\IPackageDataList;


class Promotion  implements IPromotion
{

    public IPackageDataList $Packages;
    public IFileData $Photo;
    public IPromotionDetailDataList $Details;
    public IProductDataList $Products;
    public string $Description;
    public int $EndDate;//long
    public int $StartDate;//long
    public IDiscountData $Discount;
    public int $State;
    public int $OrderNo;
    public string $ID;
    public string $Name;
}