

'''
1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

'''

def get_days_in_month(month, year):
    days_in_month = [None, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
    if month == 2:
        if year % 4 == 0:
            if year % 100 == 0 and year % 400 != 0:
                return days_in_month[month]
            return days_in_month[month] + 1
    return days_in_month[month]

    
if __name__ == '__main__':
    sundays = 0
    day_of_the_week = 1 # used as an index to keep a rolling track of days
    for year in xrange (1900, 2001):
        for month in xrange (1, 13):
            days = get_days_in_month(month, year)
            for day in range(1, days+1):
                if year > 1900 and day == 1 and day_of_the_week == 7:
                    sundays = sundays + 1
                day_of_the_week = day_of_the_week + 1
                if day_of_the_week == 8: # reset the index counter back to the beginning
                    day_of_the_week = 1
    print sundays



