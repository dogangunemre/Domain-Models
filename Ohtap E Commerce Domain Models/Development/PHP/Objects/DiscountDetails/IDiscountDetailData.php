<?php

namespace Ohtap\ECommerce\DomainModels\Objects\DiscountDetail;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IDiscountDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
