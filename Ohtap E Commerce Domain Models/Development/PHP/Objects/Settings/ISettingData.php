<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Settings;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ISettingData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
