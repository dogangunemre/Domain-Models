<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Coupons;
use Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ICouponData extends ICouponDiscount,ICouponEndDate,ICouponStartDate,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{


}