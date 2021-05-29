<?php

namespace Ohtap\ECommerce\DomainModels\Objects\CouponDetail;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ICouponDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
