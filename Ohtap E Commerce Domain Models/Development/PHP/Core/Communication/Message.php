<?php
namespace Ohtap\ECommerce\DomainModels\Core\Communication;


class Message implements IMessage
{
    public $InfoCode;
    public $Title;
    public $Description;

    public function __construct(string $InfoCode = null, string $Title = null, string $Description = null)
    {
        $this->InfoCode = $InfoCode;
        $this->Title = $Title;
        $this->Description = $Description;
    }
}
