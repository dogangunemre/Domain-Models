<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Campaigns;
use Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ICampaignData extends ICampaignPhotos,ICampaignEndDate,ICampaignStartDate,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{


}