﻿using CookPopularCSharpToolkit.Communal;
using CookPopularCSharpToolkit.Windows.Expression;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media.Animation;



/*
 * Copyright (c) 2021 All Rights Reserved.
 * Description：AnimationHelper
 * Author： Chance_写代码的厨子
 * Create Time：2021-05-21 09:39:08
 */
namespace CookPopularCSharpToolkit.Windows
{
    public class AnimationHelper
    {
        public static DoubleAnimation CreateDoubleAnimation(double toValue, double milliseconds = 200)
        {
            return new DoubleAnimation(toValue, new Duration(TimeSpan.FromMilliseconds(milliseconds)))
            {
                EasingFunction = new PowerEase { EasingMode = EasingMode.EaseInOut }
            };
        }

        public static DoubleAnimation CreateDoubleAnimation(double from, double to, double seconds = 3)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = from;
            animation.To = to;
            animation.Duration = new Duration(TimeSpan.FromSeconds(seconds));

            return animation;
        }



        public static bool Animate(Point currentValue, Vector currentVelocity, Point targetValue, double attractionFator, double dampening, double terminalVelocity, double minValueDelta, double minVelocityDelta, out Point newValue, out Vector newVelocity)
        {
            Debug.Assert(currentValue.IsValid());
            Debug.Assert(currentVelocity.IsValid());
            Debug.Assert(targetValue.IsValid());

            Debug.Assert(dampening.IsValid());
            Debug.Assert(dampening > 0 && dampening < 1);

            Debug.Assert(attractionFator.IsValid());
            Debug.Assert(attractionFator > 0);

            Debug.Assert(terminalVelocity > 0);

            Debug.Assert(minValueDelta > 0);
            Debug.Assert(minVelocityDelta > 0);

            Vector diff = targetValue.Subtract(currentValue);

            if (diff.Length > minValueDelta || currentVelocity.Length > minVelocityDelta)
            {
                newVelocity = currentVelocity * (1 - dampening);
                newVelocity += diff * attractionFator;
                if (currentVelocity.Length > terminalVelocity)
                {
                    newVelocity *= terminalVelocity / currentVelocity.Length;
                }

                newValue = currentValue + newVelocity;

                return true;
            }
            else
            {
                newValue = targetValue;
                newVelocity = new Vector();
                return false;
            }
        }
    }
}