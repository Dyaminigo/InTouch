/**
 * This file\code is part of InTouch project.
 *
 * InTouch - is a .NET wrapper for the vk.com API.
 * https://github.com/virtyaluk/InTouch
 *
 * Copyright (c) 2016 Bohdan Shtepan
 * http://modern-dev.com/
 *
 * Licensed under the GPLv3 license.
 */

namespace ModernDev.InTouch
{
    /// <summary>
    /// An <see cref="MarketCreateCommentParams"/> class describes a <see cref="MarketMethods.GetComments"/> method params.
    /// </summary>
    public class MarketGetCommentsParams : BaseGetCommentsParams
    {
        /// <summary>
        /// Item Id.
        /// </summary>
        [MethodParam(Name = "item_id", IsRequired = true)]
        public int ItemId { get; set; }
    }
}