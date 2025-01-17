﻿using CookPopularControl.Communal.Data;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;



/*
 * Copyright (c) 2021 All Rights Reserved.
 * Description：InterTabTransfer
 * Author： Chance_写代码的厨子
 * Create Time：2021-08-11 15:32:37
 */
namespace CookPopularControl.Controls.Dragables
{
    internal class InterTabTransfer
    {
        private readonly object _item;
        private readonly DragableItem _originatorContainer;
        private readonly Orientation _breachOrientation;
        private readonly Point _dragStartWindowOffset;
        private readonly Point _dragStartItemOffset;
        private readonly Point _itemPositionWithinHeader;
        private readonly Size _itemSize;
        private readonly IList<FloatingItemSnapShot> _floatingItemSnapShots;
        private readonly bool _isTransposing;
        private readonly InterTabTransferReason _transferReason;

        public InterTabTransfer(object item, DragableItem originatorContainer, Orientation breachOrientation, Point dragStartWindowOffset, Point dragStartItemOffset, Point itemPositionWithinHeader, Size itemSize, IList<FloatingItemSnapShot> floatingItemSnapShots, bool isTransposing)
        {
            if (item == null) throw new ArgumentNullException("item");
            if (originatorContainer == null) throw new ArgumentNullException("originatorContainer");
            if (floatingItemSnapShots == null) throw new ArgumentNullException("floatingItemSnapShots");

            _transferReason = InterTabTransferReason.Breach;

            _item = item;
            _originatorContainer = originatorContainer;
            _breachOrientation = breachOrientation;
            _dragStartWindowOffset = dragStartWindowOffset;
            _dragStartItemOffset = dragStartItemOffset;
            _itemPositionWithinHeader = itemPositionWithinHeader;
            _itemSize = itemSize;
            _floatingItemSnapShots = floatingItemSnapShots;
            _isTransposing = isTransposing;
        }

        public InterTabTransfer(object item, DragableItem originatorContainer, Point dragStartItemOffset,
            IList<FloatingItemSnapShot> floatingItemSnapShots)
        {
            if (item == null) throw new ArgumentNullException("item");
            if (originatorContainer == null) throw new ArgumentNullException("originatorContainer");
            if (floatingItemSnapShots == null) throw new ArgumentNullException("floatingItemSnapShots");

            _transferReason = InterTabTransferReason.Reentry;

            _item = item;
            _originatorContainer = originatorContainer;
            _dragStartItemOffset = dragStartItemOffset;
            _floatingItemSnapShots = floatingItemSnapShots;
        }

        public Orientation BreachOrientation
        {
            get { return _breachOrientation; }
        }

        public Point DragStartWindowOffset
        {
            get { return _dragStartWindowOffset; }
        }

        public object Item
        {
            get { return _item; }
        }

        public DragableItem OriginatorContainer
        {
            get { return _originatorContainer; }
        }

        public InterTabTransferReason TransferReason
        {
            get { return _transferReason; }
        }

        public Point DragStartItemOffset
        {
            get { return _dragStartItemOffset; }
        }

        public Point ItemPositionWithinHeader
        {
            get { return _itemPositionWithinHeader; }
        }

        public Size ItemSize
        {
            get { return _itemSize; }
        }

        public IList<FloatingItemSnapShot> FloatingItemSnapShots
        {
            get { return _floatingItemSnapShots; }
        }

        public bool IsTransposing
        {
            get { return _isTransposing; }
        }
    }
}
