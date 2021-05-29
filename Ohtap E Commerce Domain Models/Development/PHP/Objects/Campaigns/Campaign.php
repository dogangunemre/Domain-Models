<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Campaigns;


class Campaign  implements ICampaign

{   public $ID;
    public $Photos;//FileDataList
    public $EndDate;
    public $StartDate;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;

}

