<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;

use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;
use Ohtap\ECommerce\DomainModels\Objects\Files\IFileData;
use Ohtap\ECommerce\DomainModels\Objects\Languages\ILanguage;
use Ohtap\ECommerce\DomainModels\Objects\Packages\IPackageDataList;


class PromotionDetail  implements IPromotion
{

    public ILanguage $Language;
    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $Name;

}