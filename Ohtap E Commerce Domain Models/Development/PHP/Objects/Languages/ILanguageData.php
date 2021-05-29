<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Languages;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ILanguageData extends ILanguageLanguageCode, CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
