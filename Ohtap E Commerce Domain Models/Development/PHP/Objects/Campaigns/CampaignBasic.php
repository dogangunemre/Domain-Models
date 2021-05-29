<?php


namespace Ohtap\ECommerce\DomainModels\Objects\Campaigns;


class CampaignBasic implements ICampaignData
{
    public $ID;
    public $Photos;//IFileDataList
    public $EndDate;
    public $StartDate;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;


}