<?php

namespace Ohtap\ECommerce\DomainModels\Objects\LanguageDetails;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ILanguageDetailData extends ILanguageDetailLanguageDetailCode, CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
