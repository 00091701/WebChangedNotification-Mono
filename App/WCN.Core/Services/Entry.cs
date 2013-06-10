/*
 * This file is part of WebChangedNotification
 * Copyright (C) 2013 David Hoffmann
 *
 * WebChangedNotification is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation, version 2.
 *
 * WebChangedNotification is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with WebChangedNotification; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 *
 */


using System;
using System.Collections.Generic;

namespace De.Dhoffmann.Mono.WCN.Core.Services
{
	public class Entry
	{
		public string Name { get; set; }
		public int Intervall { get; set; }

		public List<CheckUrl> Urls { get; set; }
	}
}

