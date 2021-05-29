<?php
namespace Ohtap\ECommerce\DomainModels\Core\Communication;

use Ohtap\ECommerce\DomainModels\Core\System\Lista;

class MessageList extends Lista implements IMessageList
{
    public function AddMessage(string $InfoCode = null, string $Title = null, string $Description = null)
    {
        parent::Add(new Message($InfoCode, $Title, $Description));
    }
}
