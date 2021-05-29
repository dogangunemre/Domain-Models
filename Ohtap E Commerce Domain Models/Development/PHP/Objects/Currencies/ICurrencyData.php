<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Currencies;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ICurrencyData extends ICurrencyFundCode,ICurrencySymbol,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
