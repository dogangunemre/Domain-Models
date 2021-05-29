<?php

namespace Ohtap\ECommerce\DomainModels\Objects\CurrencyDetail;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ICurrencyDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
